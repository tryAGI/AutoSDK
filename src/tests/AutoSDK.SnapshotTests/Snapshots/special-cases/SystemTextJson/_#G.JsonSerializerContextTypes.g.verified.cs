//HintName: G.JsonSerializerContextTypes.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PartialMappedEvent? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MappedStartEvent? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MappedStopEvent? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PartialMappedEventDiscriminator? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PartialMappedEventDiscriminatorKind? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Match? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MatchEqual? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MatchRange? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DefsUnion? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DefsChunk? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DefsError? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Pet? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Pet>? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Error? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type18 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Pet>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
    }
}