//HintName: G.JsonConverters.QueryHistorySpan.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class QueryHistorySpanJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.QueryHistorySpan>
    {
        /// <inheritdoc />
        public override global::G.QueryHistorySpan Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryHistorySpanDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryHistorySpanDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.QueryHistorySpanDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RephraseSpan? rephrase = default;
            if (discriminator?.Type == global::G.QueryHistorySpanDiscriminatorType.Rephrase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RephraseSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RephraseSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RephraseSpan)}");
                rephrase = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SearchSpan? search = default;
            if (discriminator?.Type == global::G.QueryHistorySpanDiscriminatorType.Search)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SearchSpan)}");
                search = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RerankSpan? rerank = default;
            if (discriminator?.Type == global::G.QueryHistorySpanDiscriminatorType.Rerank)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RerankSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RerankSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RerankSpan)}");
                rerank = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerationSpan? generation = default;
            if (discriminator?.Type == global::G.QueryHistorySpanDiscriminatorType.Generation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerationSpan)}");
                generation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FactualConsistencyScoreSpan? fcs = default;
            if (discriminator?.Type == global::G.QueryHistorySpanDiscriminatorType.Fcs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FactualConsistencyScoreSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FactualConsistencyScoreSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FactualConsistencyScoreSpan)}");
                fcs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RewrittenQuerySpan? rewrittenQuery = default;
            if (discriminator?.Type == global::G.QueryHistorySpanDiscriminatorType.RewrittenQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RewrittenQuerySpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RewrittenQuerySpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RewrittenQuerySpan)}");
                rewrittenQuery = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.QueryHistorySpan(
                discriminator?.Type,
                rephrase,
                search,
                rerank,
                generation,
                fcs,
                rewrittenQuery
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.QueryHistorySpan value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRephrase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RephraseSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RephraseSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RephraseSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rephrase, typeInfo);
            }
            else if (value.IsSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SearchSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search, typeInfo);
            }
            else if (value.IsRerank)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RerankSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RerankSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RerankSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rerank, typeInfo);
            }
            else if (value.IsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generation, typeInfo);
            }
            else if (value.IsFcs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FactualConsistencyScoreSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FactualConsistencyScoreSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FactualConsistencyScoreSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Fcs, typeInfo);
            }
            else if (value.IsRewrittenQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RewrittenQuerySpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RewrittenQuerySpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RewrittenQuerySpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RewrittenQuery, typeInfo);
            }
        }
    }
}