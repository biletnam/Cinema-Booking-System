//Julian Blair 131025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bioprogram
{
    public class SeatManager
    {
        private string[] m_name_List;
        private double[] m_price_List;

        /// <summary>
        /// Creates the array for m_name_List and m_price_List
        /// </summary>
        /// <param name="max"></param>
        public SeatManager(int max) 
        {
            m_name_List = new string[max];
            m_price_List = new double[max];
            for (int i = 0; i < NumberOfSeats(); i++)
            {
                m_name_List[i] = string.Empty;
                m_price_List[i] = 0.0;
            }
        }

        /// <summary>
        /// Returns total number of seats
        /// </summary>
        /// <returns></returns>
        public int NumberOfSeats() 
        {
            return m_name_List.Length;
        }

        /// <summary>
        /// returns formatted string
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetText(int index)
        {
            string columns;
            if (isSeatFree(index))
            {
                return columns = String.Format("{0,3} {1,10} {2,8} {3,10} ", index + 1, "vacant", string.Empty, 0);
            }

            else return columns = String.Format("{0,3} {1,10} {2,8} {3,10}", index + 1, "reserved", m_name_List[index], m_price_List[index]);
        }

        /// <summary>
        /// reserves selected seat if the seat is free and the position is within the array
        /// </summary>
        /// <param name="position"></param>
        /// <param name="price"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool reserve(int position, double price, string name)
        {
            if (!isSeatFree(position) || !IsPositionOk(position))
            {
                return false;
            }
            m_name_List[position] = name;
            m_price_List[position] = price;
            return true;
        }

        /// <summary>
        /// sets the selected position to an empty string if the position is not free
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool unbook(int position) //this method is called in Main
        {
            if (isSeatFree(position))
            {
                return false;
            }
            m_name_List[position] = string.Empty;
            m_price_List[position] = 0;
            return true;
        }

        /// <summary>
        /// check if selected position is within range of array
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool IsPositionOk(int index)
        {
            if ((index >= 0) && (index < NumberOfSeats()))
            {
                return true;
            }
            else return false;
        }
        
        /// <summary>
        /// returns number of reserved seats
        /// </summary>
        /// <returns></returns>
        public int GetNumReserved()
        {
            int numberOfReservedSeats = 0;
            for (int position = 0; position < m_name_List.Length; position++)
            {
                if (!isSeatFree(position))
                {
                    numberOfReservedSeats = numberOfReservedSeats + 1;
                }
            }
            return numberOfReservedSeats;
        }

        /// <summary>
        /// returns numner of vacant seats
        /// </summary>
        /// <returns></returns>
        public int GetNumVacant()
        {
            int numberOfVacantSeats = NumberOfSeats() - GetNumReserved();
            return numberOfVacantSeats;
        }

        /// <summary>
        /// checks if position at selected index is free
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool isSeatFree(int position) // changed this from private to public so i could use it in main
        {
            if (m_name_List[position] != string.Empty)
            {
                return false;
            }

            else return true;
        }
    }
}
