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

    public static class RunStepDetailsMessageCreationObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDetailsMessageCreationObjectType value)
        {
            return value switch
            {
                RunStepDetailsMessageCreationObjectType.MessageCreation => "message_creation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsMessageCreationObjectType ToEnum(string value)
        {
            return value switch
            {
                "message_creation" => RunStepDetailsMessageCreationObjectType.MessageCreation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsMessageCreationObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDetailsMessageCreationObjectType.MessageCreation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}