//HintName: G.Models.CodeScanningOrganizationAlertItemsState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningOrganizationAlertItemsState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningOrganizationAlertItemsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningOrganizationAlertItemsState value)
        {
            return value switch
            {
                CodeScanningOrganizationAlertItemsState.Open => "open",
                CodeScanningOrganizationAlertItemsState.Dismissed => "dismissed",
                CodeScanningOrganizationAlertItemsState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningOrganizationAlertItemsState ToEnum(string value)
        {
            return value switch
            {
                "open" => CodeScanningOrganizationAlertItemsState.Open,
                "dismissed" => CodeScanningOrganizationAlertItemsState.Dismissed,
                "fixed" => CodeScanningOrganizationAlertItemsState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}