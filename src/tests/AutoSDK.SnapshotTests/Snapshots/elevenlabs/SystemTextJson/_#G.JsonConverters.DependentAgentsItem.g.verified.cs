//HintName: G.JsonConverters.DependentAgentsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DependentAgentsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DependentAgentsItem>
    {
        /// <inheritdoc />
        public override global::G.DependentAgentsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminator>(ref readerCopy, options);

            global::G.DependentAvailableAgentIdentifier? available = default;
            if (discriminator?.Type == global::G.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType.Available)
            {
                available = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependentAvailableAgentIdentifier>(ref reader, options);
            }
            global::G.DependentUnknownAgentIdentifier? unknown = default;
            if (discriminator?.Type == global::G.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType.Unknown)
            {
                unknown = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependentUnknownAgentIdentifier>(ref reader, options);
            }

            var __value = new global::G.DependentAgentsItem(
                discriminator?.Type,
                available,

                unknown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DependentAgentsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAvailable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeof(global::G.DependentAvailableAgentIdentifier), options);
            }
            else if (value.IsUnknown)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeof(global::G.DependentUnknownAgentIdentifier), options);
            }
        }
    }
}