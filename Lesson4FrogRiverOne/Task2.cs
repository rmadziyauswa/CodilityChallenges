using System;
using System.Text;

namespace Lesson4FrogRiverOne
{
    public class Task2
    {
        public string solution(string S)
        {
            var sNew = S.Replace(" ", "").Replace("-", "");
            var result = new StringBuilder();
            var continuex = true;
            while (continuex)
            {
                if(sNew.Length >= 5)
                {
                    var chunk = sNew.Substring(0, 3);
                    result.Append(chunk);
                    sNew = sNew.Remove(0, 3);
                    if(sNew.Length > 0)
                    {
                        result.Append("-");
                    }
                }else if(sNew.Length > 0 && sNew.Length < 5)
                {
                    if(sNew.Length == 4)
                    {
                        var chunk2 = sNew.Substring(0, 2);
                        result.Append(chunk2);
                        result.Append("-");
                        var chunk22 = sNew.Substring(2, 2);
                        result.Append(chunk22);

                    }
                    else
                    {
                        var chunk = sNew.Substring(0, sNew.Length);
                        result.Append(chunk);
                        sNew = sNew.Remove(0, sNew.Length);
                        if (sNew.Length > 0)
                        {
                            result.Append("-");
                        }
                    }
               
                }
                else
                {
                    continuex = false;
                }
            }

            return result.ToString();
        }
    }
}
