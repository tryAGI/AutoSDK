//HintName: G.Models.CreateCompletionResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "text_completion"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCompletionResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_completion")]
        TextCompletion,
    }

    public static class CreateCompletionResponseObjectExtensions
    {
        public static string ToValueString(this CreateCompletionResponseObject value)
        {
            return value switch
            {
                CreateCompletionResponseObject.TextCompletion => "text_completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateCompletionResponseObject ToEnum(string value)
        {
            return value switch
            {
                "text_completion" => CreateCompletionResponseObject.TextCompletion,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateCompletionResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => CreateCompletionResponseObject.TextCompletion,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}