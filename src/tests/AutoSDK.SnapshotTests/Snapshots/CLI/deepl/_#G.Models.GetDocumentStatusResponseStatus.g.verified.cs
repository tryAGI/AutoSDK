//HintName: G.Models.GetDocumentStatusResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A short description of the state the document translation process is currently in. Possible values are:<br/>
    ///  * `queued` - the translation job is waiting in line to be processed<br/>
    ///  * `translating` - the translation is currently ongoing<br/>
    ///  * `done` - the translation is done and the translated document is ready for download<br/>
    ///  * `error` - an irrecoverable error occurred while translating the document
    /// </summary>
    public enum GetDocumentStatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Translating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocumentStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentStatusResponseStatus value)
        {
            return value switch
            {
                GetDocumentStatusResponseStatus.Done => "done",
                GetDocumentStatusResponseStatus.Error => "error",
                GetDocumentStatusResponseStatus.Queued => "queued",
                GetDocumentStatusResponseStatus.Translating => "translating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => GetDocumentStatusResponseStatus.Done,
                "error" => GetDocumentStatusResponseStatus.Error,
                "queued" => GetDocumentStatusResponseStatus.Queued,
                "translating" => GetDocumentStatusResponseStatus.Translating,
                _ => null,
            };
        }
    }
}