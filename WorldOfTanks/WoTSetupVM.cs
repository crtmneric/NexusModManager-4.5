
namespace Nexus.Client.Games.WorldOfTanks
{
	/// <summary>
	/// This class encapsulates the data and the operations presented by UI
    /// elements that display the setup for WorldOfTanks game mode.
	/// </summary>
	public class WoTSetupVM : SetupBaseVM
	{
		#region Constructors

		/// <summary>
		/// A simple constructor that initializes the object with the given values.
		/// </summary>
		/// <param name="p_eifEnvironmentInfo">The application's envrionment info.</param>
		/// <param name="p_gmdGameModeInfo">The descriptor for the game mode being set up.</param>
		public WoTSetupVM(IEnvironmentInfo p_eifEnvironmentInfo, IGameModeDescriptor p_gmdGameModeInfo)
			:base(p_eifEnvironmentInfo, p_gmdGameModeInfo)
		{
		}

		#endregion
	}
}
