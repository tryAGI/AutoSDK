//HintName: G.Models.EvalGroqModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model (`groq`).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalGroqModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="groq")]
        Groq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalGroqModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalGroqModelProvider value)
        {
            return value switch
            {
                EvalGroqModelProvider.Groq => "groq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalGroqModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "groq" => EvalGroqModelProvider.Groq,
                _ => null,
            };
        }
    }
}