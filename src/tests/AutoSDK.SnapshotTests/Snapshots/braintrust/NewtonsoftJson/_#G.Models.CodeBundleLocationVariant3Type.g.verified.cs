//HintName: G.Models.CodeBundleLocationVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeBundleLocationVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sandbox")]
        Sandbox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeBundleLocationVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeBundleLocationVariant3Type value)
        {
            return value switch
            {
                CodeBundleLocationVariant3Type.Sandbox => "sandbox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeBundleLocationVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "sandbox" => CodeBundleLocationVariant3Type.Sandbox,
                _ => null,
            };
        }
    }
}