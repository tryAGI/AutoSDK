//HintName: G.Models.InstallationTokenRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InstallationTokenRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InstallationTokenRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstallationTokenRepositorySelection value)
        {
            return value switch
            {
                InstallationTokenRepositorySelection.All => "all",
                InstallationTokenRepositorySelection.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstallationTokenRepositorySelection? ToEnum(string value)
        {
            return value switch
            {
                "all" => InstallationTokenRepositorySelection.All,
                "selected" => InstallationTokenRepositorySelection.Selected,
                _ => null,
            };
        }
    }
}