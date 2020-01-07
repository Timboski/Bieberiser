using System;

namespace Bieberiser
{
    class Program
    {
        static void Main(string[] args)
        {
            var bieber = new RandomBieber();
            Wallpaper.Set(bieber.Uri, bieber.Style);
        }
    }
}
