using System;

namespace Bieberiser
{
    class RandomBieber
    {
        private static readonly (string Uri, Wallpaper.Style Style)[] Biebers = {
            ( "https://www.biography.com/.image/ar_1:1%2Cc_fill%2Ccs_srgb%2Cg_face%2Cq_auto:good%2Cw_300/MTM2OTI2NTY2Mjg5NTE2MTI5/justin_bieber_2015_photo_courtesy_dfree_shutterstock_348418241_croppedjpg.jpg", Wallpaper.Style.Centered ),
            ( "https://ichef.bbci.co.uk/news/912/cpsprodpb/6448/production/_104127652_gettyimages-1052301996.jpg", Wallpaper.Style.Centered ),
            ( "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/10/1/1443700599834/Space-cadet---new-look-Ju-009.jpg?width=1200&height=630&quality=85&auto=format&fit=crop&overlay-align=bottom%2Cleft&overlay-width=100p&overlay-base64=L2ltZy9zdGF0aWMvb3ZlcmxheXMvdGctZGVmYXVsdC5wbmc&s=e7ca3fcc50aa679606c8ee784f5be2da", Wallpaper.Style.Centered ),
            //( "https://www.bieberfever.com/wp-content/uploads/2019/01/Most-Followed-Justin-Bieber.jpg", Wallpaper.Style.Centered ),
        };

        private int _index;

        public RandomBieber() => Generate();

        public Uri Uri => new Uri(CurrentBieber.Uri);

        public Wallpaper.Style Style => CurrentBieber.Style;

        private (string Uri, Wallpaper.Style Style) CurrentBieber => Biebers[_index];

        public void Generate()
        {
            var gen = new Random();
            _index = gen.Next(Biebers.Length);
        }
    }
}
