//HintName: G.Models.InputAudioAppend.BinaryPayloads.g.cs

#nullable enable

namespace G
{
    public sealed partial class InputAudioAppend
    {
        /// <summary>
        /// Gets the decoded bytes for <see cref="Data" />.
        /// </summary>
        [global::Newtonsoft.Json.JsonIgnore]
        public global::System.ReadOnlyMemory<byte> DataBytes => Data is null
            ? default
            : global::System.Convert.FromBase64String(Data);
    }
}