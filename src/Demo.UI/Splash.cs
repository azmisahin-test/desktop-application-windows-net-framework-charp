namespace Demo.UI
{
  using System.Windows.Forms;

  /// <summary>
  /// 
  /// </summary>
  public partial class Splash : Form
  {
    Timer timer;

    /// <summary>
    /// 
    /// </summary>
    public Splash()
    {
      InitializeComponent();
      // 
      lblVersion.Text = $"core version {new Demo.Core.App().Version}";
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Splash_Shown(object sender, System.EventArgs e)
    {
      timer = new Timer();
      timer.Interval = 5000;
      timer.Start();
      timer.Tick += Timer_Tick;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="System.NotImplementedException"></exception>
    private void Timer_Tick(object sender, System.EventArgs e)
    {
      timer.Stop();
      Main main = new Main();
      main.Show();
      this.Hide();
    }
  }
}
