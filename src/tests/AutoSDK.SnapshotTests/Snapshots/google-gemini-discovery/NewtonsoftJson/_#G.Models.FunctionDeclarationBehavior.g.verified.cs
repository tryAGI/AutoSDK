//HintName: G.Models.FunctionDeclarationBehavior.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Specifies the function Behavior. Currently only supported by the BidiGenerateContent method.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionDeclarationBehavior
    {
        /// <summary>
        /// If set, the system will wait to receive the function response before continuing the conversation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCKING")]
        Blocking,
        /// <summary>
        /// If set, the system will not wait to receive the function response. Instead, it will attempt to handle function responses as they become available while maintaining the conversation between the user and the model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NON_BLOCKING")]
        NonBlocking,
        /// <summary>
        /// This value is unused.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNSPECIFIED")]
        Unspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDeclarationBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDeclarationBehavior value)
        {
            return value switch
            {
                FunctionDeclarationBehavior.Blocking => "BLOCKING",
                FunctionDeclarationBehavior.NonBlocking => "NON_BLOCKING",
                FunctionDeclarationBehavior.Unspecified => "UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDeclarationBehavior? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKING" => FunctionDeclarationBehavior.Blocking,
                "NON_BLOCKING" => FunctionDeclarationBehavior.NonBlocking,
                "UNSPECIFIED" => FunctionDeclarationBehavior.Unspecified,
                _ => null,
            };
        }
    }
}