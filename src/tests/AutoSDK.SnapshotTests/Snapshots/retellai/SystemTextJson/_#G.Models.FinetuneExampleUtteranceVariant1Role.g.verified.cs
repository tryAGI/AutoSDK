//HintName: G.Models.FinetuneExampleUtteranceVariant1Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneExampleUtteranceVariant1Role
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneExampleUtteranceVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneExampleUtteranceVariant1Role value)
        {
            return value switch
            {
                FinetuneExampleUtteranceVariant1Role.Agent => "agent",
                FinetuneExampleUtteranceVariant1Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneExampleUtteranceVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "agent" => FinetuneExampleUtteranceVariant1Role.Agent,
                "user" => FinetuneExampleUtteranceVariant1Role.User,
                _ => null,
            };
        }
    }
}