//HintName: G.Models.Mgmtv1betaStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status describes the output of an execution.<br/>
    ///  - STATUS_COMPLETED: Successfully completed.<br/>
    ///  - STATUS_ERRORED: Finished with error.
    /// </summary>
    public enum Mgmtv1betaStatus
    {
        /// <summary>
        /// Successfully completed.
        /// </summary>
        STATUSCOMPLETED,
        /// <summary>
        /// Finished with error.
        /// </summary>
        STATUSERRORED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Mgmtv1betaStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Mgmtv1betaStatus value)
        {
            return value switch
            {
                Mgmtv1betaStatus.STATUSCOMPLETED => "STATUS_COMPLETED",
                Mgmtv1betaStatus.STATUSERRORED => "STATUS_ERRORED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Mgmtv1betaStatus? ToEnum(string value)
        {
            return value switch
            {
                "STATUS_COMPLETED" => Mgmtv1betaStatus.STATUSCOMPLETED,
                "STATUS_ERRORED" => Mgmtv1betaStatus.STATUSERRORED,
                _ => null,
            };
        }
    }
}