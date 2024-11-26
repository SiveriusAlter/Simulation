using System.Collections.ObjectModel;

namespace Simulation.ViewModels
{
    public class CanvasTile
    {
        public int TopX { get; private set; } = 20;
        public int TopY { get; private set; } = 15;

        public CanvasTile( int TopX, int TopY)
        {
            this.TopX = TopX;
            this.TopY = TopY;
        }
    }

    public class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static



        public ObservableCollection<CanvasTile> Tiles { get; } = new ObservableCollection<CanvasTile>();


        public int X { get; set; } = 10;
        public int Y { get; set; } = 20;

        public MainWindowViewModel() 
        {
            Tiles.Add(new CanvasTile( 1 * X, 1 * Y));
            Tiles.Add(new CanvasTile( 2 * X, 2 * Y));
            Tiles.Add(new CanvasTile( 4 * X, 4 * Y));
        }
    }
}
