using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace Avalonia.ExampleApp.Model
{
    public class FolderItem
    {
        public string Folder { get; set; }
        public Bitmap Image { get; set; }

        public FolderItem()
        {
            Uri uri = new Uri("/Assets/openfolderHS.png", UriKind.Relative);
            //.orig
            //var assets = AvaloniaLocator.GetService<AssetLoader>();
            //Image= new Bitmap(assets.Open(uri));
        }
    }
}
