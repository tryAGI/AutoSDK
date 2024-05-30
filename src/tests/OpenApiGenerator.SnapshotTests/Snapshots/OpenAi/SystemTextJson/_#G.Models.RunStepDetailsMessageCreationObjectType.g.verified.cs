//HintName: G.Models.RunStepDetailsMessageCreationObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `message_creation`.
    /// </summary>
    public enum RunStepDetailsMessageCreationObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageCreation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDetailsMessageCreationObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDetailsMessageCreationObjectType value)
        {
            return value switch
            {
                RunStepDetailsMessageCreationObjectType.MessageCreation => "message_creation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDetailsMessageCreationObjectType ToEnum(string value)
        {
            return value switch
            {
                "message_creation" => RunStepDetailsMessageCreationObjectType.MessageCreation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}