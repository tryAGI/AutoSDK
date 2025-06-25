//HintName: G.Models.InstallationRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    public enum InstallationRepositorySelection
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
    public static class InstallationRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstallationRepositorySelection value)
        {
            return value switch
            {
                InstallationRepositorySelection.All => "all",
                InstallationRepositorySelection.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstallationRepositorySelection? ToEnum(string value)
        {
            return value switch
            {
                "all" => InstallationRepositorySelection.All,
                "selected" => InstallationRepositorySelection.Selected,
                _ => null,
            };
        }
    }
}