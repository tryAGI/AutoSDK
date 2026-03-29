//HintName: G.Models.ApplyPatchCallContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: apply_patch_call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApplyPatchCallContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apply_patch_call")]
        ApplyPatchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallContentType value)
        {
            return value switch
            {
                ApplyPatchCallContentType.ApplyPatchCall => "apply_patch_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallContentType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => ApplyPatchCallContentType.ApplyPatchCall,
                _ => null,
            };
        }
    }
}