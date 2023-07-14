using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResDiary
{
    public class Utils
    {
        /// <summary>
        /// Splits an integer array into a desired number of roughly equally sized groups
        /// </summary>
        /// <param name="elements">The array to split. Must not be null</param>
        /// <param name="howManyGroups">A positive integer denoting how many groups to split 'elements' into</param>
        /// <returns>A list containing 'howManyGroups' number of integer arrays</returns>
        public static List<int[]> groupArrayElements(int[] elements, int howManyGroups)
        {
            List<int[]> result = new List<int[]>();

            if (elements.Length == 0) { return result; }

            int groupLength = (int)Math.Round((double)elements.Length / howManyGroups);

            // Create every group except the last
            List<int> elementsList = elements.ToList();
            for (int groupNumber = 0; groupNumber < howManyGroups - 1; groupNumber++)
            {
                int[] group = elementsList.Take(groupLength).ToArray();
                elementsList.RemoveRange(0, groupLength); // remove the elements we just took from the array
                result.Add(group);
            }
            
            // whatever is left in 'elements' will constitute the last group
            result.Add(elementsList.ToArray());

            return result;
        }



        /// <summary>
        /// I didn't write this, my IDE generated most of it!
        /// </summary>
        /// <param name="toPrint"></param>
        /// <returns></returns>
        public static string printableElements(List<int[]> toPrint)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int[] element in toPrint)
            {
                if (sb.Length > 1) sb.Append(", ");
                sb.Append(printableElements(element));
            }
            sb.Append("]");
            return sb.ToString();
        }

        /// <summary>
        /// I didn't write this, my IDE generated most of it!
        /// </summary>
        /// <param name="toPrint"></param>
        /// <returns></returns>
        public static string printableElements(int[] toPrint)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int element in toPrint)
            {
                if (sb.Length > 1) sb.Append(", ");
                sb.Append(element);
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
