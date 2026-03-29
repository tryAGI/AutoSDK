//HintName: G.Models.ApplyPatchCallOutputContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: apply_patch_call_output
    /// </summary>
    public enum ApplyPatchCallOutputContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOutputContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOutputContentType value)
        {
            return value switch
            {
                ApplyPatchCallOutputContentType.ApplyPatchCallOutput => "apply_patch_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOutputContentType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call_output" => ApplyPatchCallOutputContentType.ApplyPatchCallOutput,
                _ => null,
            };
        }
    }
}