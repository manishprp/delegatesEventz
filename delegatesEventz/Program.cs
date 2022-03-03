using System;

namespace delegatesEventz
{
    public delegate void operation(int x, int y);
    class publisher
    {
        public event operation even;
        public void invokeMethod(int x, int y)
        {
            even?.Invoke(x,y);
        }
    }
    
}