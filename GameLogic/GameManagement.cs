using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class GameManagement
    {
        private const int k_NumOfGuess = 4;
        private const int k_MaxNumOfGuesses = 10;
        private const int k_MinNumOfGuesses = 4;
        private const int k_MinCharToGuess = 'A';
        private const int k_MaxCharToGuess = 'H';
        private readonly int r_NumOfGuesses;
        private readonly string r_SequenceSolution = null;
        private readonly Random r_Random = new Random();
        private int m_CurrentNumOfSteps = 0;
        private bool m_IsPlayerWon = false;
        private bool m_IsPlayerLost = false;
        
        public GameManagement(int i_NumOfGuesses)
        {
            r_NumOfGuesses = i_NumOfGuesses;
            r_SequenceSolution = generateSolution();
        }

        public static int MinNumOfGuesses
        {
            get
            {
                return k_MinNumOfGuesses;
            }
        }

        public static int MaxNumOfGuesses
        {
            get
            {
                return k_MaxNumOfGuesses;
            }
        }

        private static bool isValidGuess(string i_UserGuessStr)
        {
            bool isValidGuess = i_UserGuessStr.Distinct().Count() == k_NumOfGuess;

            return isValidGuess;
        }

        public int CurrentNumOfSteps
        {
            get
            {
                return m_CurrentNumOfSteps;
            }

            set
            {
                m_CurrentNumOfSteps = value;
                if (!m_IsPlayerWon)
                {
                    m_IsPlayerLost = isGameOver();
                }
            }
        }

        public bool IsPlayerWon
        {
            get
            {
                return m_IsPlayerWon;
            }
        }

        public bool IsPlayerLost
        {
            get
            {
                return m_IsPlayerLost;
            }
        }

        public string Solution
        {
            get
            {
                return r_SequenceSolution;
            }
        }

        private string generateSolution()
        {
            List<char> solutionList = new List<char>();
            int solutionLength = 0;

            while (solutionLength < k_NumOfGuess)
            {
                char randChar = (char)r_Random.Next(k_MinCharToGuess, k_MaxCharToGuess + 1);

                if (!solutionList.Contains(randChar))
                {
                    solutionList.Add(randChar);
                    solutionLength++;
                }
            }

            return new string(solutionList.ToArray());
        }

        public bool GetResults(string i_NewGuess, out int o_NumberOfBull, out int o_NumberOfCows)
        {
            string guessWithOutSpaces = i_NewGuess.Replace(" ", string.Empty);
            string solutionWithOutSpaces = r_SequenceSolution.Replace(" ", string.Empty);
            bool isValidGuess = GameManagement.isValidGuess(guessWithOutSpaces);

            o_NumberOfCows = 0;
            o_NumberOfBull = 0;
            if (isValidGuess)
            {
                for (int i = 0; i < solutionWithOutSpaces.Length; i++)
                {
                    if (guessWithOutSpaces[i] == solutionWithOutSpaces[i])
                    {
                        o_NumberOfBull++;
                    }
                }

                for (int i = 0; i < solutionWithOutSpaces.Length; i++)
                {
                    if (guessWithOutSpaces[i] != solutionWithOutSpaces[i] && solutionWithOutSpaces.Contains(guessWithOutSpaces[i]))
                    {
                        o_NumberOfCows++;
                    }
                }

                if (o_NumberOfBull == k_NumOfGuess)
                {
                    m_IsPlayerWon = true;
                }
            }

            return isValidGuess;
        }

        private bool isGameOver()
        {
            bool isGameOver = CurrentNumOfSteps == r_NumOfGuesses;

            return isGameOver;
        }
    }
}