//HintName: G.Models.NullableScopedInstallationRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NullableScopedInstallationRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableScopedInstallationRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableScopedInstallationRepositorySelection value)
        {
            return value switch
            {
                NullableScopedInstallationRepositorySelection.All => "all",
                NullableScopedInstallationRepositorySelection.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableScopedInstallationRepositorySelection? ToEnum(string value)
        {
            return value switch
            {
                "all" => NullableScopedInstallationRepositorySelection.All,
                "selected" => NullableScopedInstallationRepositorySelection.Selected,
                _ => null,
            };
        }
    }
}