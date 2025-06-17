//HintName: G.Models.PatchWorkspaceSecretRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchWorkspaceSecretRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update")]
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchWorkspaceSecretRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchWorkspaceSecretRequestType value)
        {
            return value switch
            {
                PatchWorkspaceSecretRequestType.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchWorkspaceSecretRequestType? ToEnum(string value)
        {
            return value switch
            {
                "update" => PatchWorkspaceSecretRequestType.Update,
                _ => null,
            };
        }
    }
}