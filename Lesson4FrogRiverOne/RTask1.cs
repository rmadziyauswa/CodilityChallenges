using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson4FrogRiverOne
{
    public class RTask1
    {
        public List<string> listOKGroups = new List<string>();
        public List<string> distinctListOfGroups = new List<string>();

        public int solution(string[] T, string[] R)
        {
            var result = 0;
            GetGroups(T,R);
            var percentage = (double)(listOKGroups.Count * 100) / distinctListOfGroups.Count;
            result = (int)Math.Floor(percentage);
            return result;
        }

        public void GetGroups(string[] T, string[] R)
        {
            var listGroups = new List<string>();
            var listNotOKGroups = new List<string>();
            for (int i = 0; i < T.Length; i++)
            {
                var item = T[i];
                var isOk = R[i].ToUpper().Equals("OK");
                var sbuilder = new StringBuilder();
                foreach (var c in item)
                {
                    if(Char.IsNumber(c))
                    {
                        sbuilder.Append(c);
                    }
                }
                var groupName = sbuilder.ToString();
                listGroups.Add(groupName);

                if (!isOk)
                {
                    listNotOKGroups.Add(groupName);
                }
            }

            distinctListOfGroups = listGroups.Distinct().ToList();
            listOKGroups = distinctListOfGroups.Where(g => !listNotOKGroups.Contains(g)).ToList();

        }
    }
}
