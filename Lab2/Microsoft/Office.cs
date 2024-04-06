using System;

namespace Microsoft
{
    internal class Office
    {
        internal class Interop
        {
            internal class Word
            {
                internal class Application
                {
                    public object Documents { get; internal set; }

                    internal void Quit()
                    {
                        throw new NotImplementedException();
                    }
                }
            }
        }
    }
}