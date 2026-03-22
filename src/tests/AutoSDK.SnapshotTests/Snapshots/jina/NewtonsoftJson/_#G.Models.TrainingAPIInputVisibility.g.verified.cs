//HintName: G.Models.TrainingAPIInputVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of the classifier when created. Will be ignored if `classifier_id` is provided<br/>
    /// Default Value: public
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TrainingAPIInputVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainingAPIInputVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingAPIInputVisibility value)
        {
            return value switch
            {
                TrainingAPIInputVisibility.Private => "private",
                TrainingAPIInputVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingAPIInputVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => TrainingAPIInputVisibility.Private,
                "public" => TrainingAPIInputVisibility.Public,
                _ => null,
            };
        }
    }
}