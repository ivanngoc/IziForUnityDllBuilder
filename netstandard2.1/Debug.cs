#if DEBUG
using System;
using System.Collections.Generic;
using System.Text;

namespace IziHardGames.DllsForUnity
{
    internal class Debug
    {
        public void Test()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(new object());
        }
    }
}

#endif