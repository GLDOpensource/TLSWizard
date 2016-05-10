using System;
using System.Collections.Generic;
using System.Text;

namespace GenerateIt {
    public class OddRandomUint32 {
        static Random r = new Random(DateTime.Now.Millisecond);
        
        public static uint Next() {
            uint m = (uint)r.Next(int.MaxValue);
            if (m % 2 == 0)
                m++;
            return m;
        }
    }
}
