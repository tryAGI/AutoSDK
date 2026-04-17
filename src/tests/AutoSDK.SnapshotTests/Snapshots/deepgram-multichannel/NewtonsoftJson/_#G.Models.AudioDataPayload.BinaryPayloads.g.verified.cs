//HintName: G.Models.AudioDataPayload.BinaryPayloads.g.cs

#nullable enable

namespace G
{
    public sealed partial class AudioDataPayload
    {
        /// <summary>
        /// Gets the decoded bytes for <see cref="AudioBase64" />.
        /// </summary>
        [global::Newtonsoft.Json.JsonIgnore]
        public global::System.ReadOnlyMemory<byte> AudioBase64Bytes => AudioBase64 is null
            ? default
            : global::System.Convert.FromBase64String(AudioBase64);
    }
}