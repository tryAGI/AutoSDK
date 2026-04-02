//HintName: G.JsonConverters.BranchInfoVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BranchInfoVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BranchInfoVariant1>
    {
        /// <inheritdoc />
        public override global::G.BranchInfoVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator>(ref readerCopy, options);

            global::G.TransferBranchInfoTrafficSplit? trafficSplit = default;
            if (discriminator?.BranchReason == global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit)
            {
                trafficSplit = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferBranchInfoTrafficSplit>(ref reader, options);
            }
            global::G.TransferBranchInfoDefaultingToMain? defaultingToMain = default;
            if (discriminator?.BranchReason == global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain)
            {
                defaultingToMain = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferBranchInfoDefaultingToMain>(ref reader, options);
            }

            var __value = new global::G.BranchInfoVariant1(
                discriminator?.BranchReason,
                trafficSplit,

                defaultingToMain
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BranchInfoVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTrafficSplit)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TrafficSplit, typeof(global::G.TransferBranchInfoTrafficSplit), options);
            }
            else if (value.IsDefaultingToMain)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DefaultingToMain, typeof(global::G.TransferBranchInfoDefaultingToMain), options);
            }
        }
    }
}