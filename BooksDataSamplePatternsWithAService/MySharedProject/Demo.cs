using System;
using System.Collections.Generic;
using System.Text;

namespace MySharedProject
{
    public class Demo
    {
        public void Foo()
        {
            
        }

#if WPF
        public void Bar()
        {

        }
#endif
    }
}
