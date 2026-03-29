//HintName: G.Models.CodeBundleLocationFunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeBundleLocationFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeBundleLocationFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeBundleLocationFunctionType value)
        {
            return value switch
            {
                CodeBundleLocationFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeBundleLocationFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => CodeBundleLocationFunctionType.Function,
                _ => null,
            };
        }
    }
}