using System;
using System.Collections.Generic;
using System.Linq;


namespace Lesson4FrogRiverOne
{
    public class Task1
    {
        public string solution(string[] A, string[] B, string P)
        {
            var result = "NO CONTACT";
            var contactsWithP = new List<string>();
            for (int i = 0; i < B.Length; i++)
            {
                if(B[i].Contains(P))
                {
                    contactsWithP.Add(A[i]);
                }
            }

            var firstContact = contactsWithP.OrderBy(s => s).FirstOrDefault();
            if(!string.IsNullOrEmpty(firstContact))
            {
                result = firstContact;
            }
            return result;
        }
    }
}
