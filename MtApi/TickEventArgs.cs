using System;
using MTApiService;

namespace MtApi
{
    public class TickEventArgs: EventArgs
    {
        public int ExpertHandle { get; }
        public MqlTick MtMqlTick { get; }


        public TickEventArgs(MqlTick mtMqlTick)
        {
            MtMqlTick = mtMqlTick;
        }

        internal TickEventArgs(int expertHandle, MqlTick mqlTick): this(mqlTick)
        {
            ExpertHandle = expertHandle;
        }
    }
}