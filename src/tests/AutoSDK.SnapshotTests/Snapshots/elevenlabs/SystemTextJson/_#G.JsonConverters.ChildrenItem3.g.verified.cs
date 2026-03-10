//HintName: G.JsonConverters.ChildrenItem3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChildrenItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChildrenItem3>
    {
        /// <inheritdoc />
        public override global::G.ChildrenItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTOrOperatorNodeInputChildrenItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTOrOperatorNodeInputChildrenItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTOrOperatorNodeInputChildrenItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ASTStringNodeInput? stringLiteral = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.StringLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTStringNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTStringNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTStringNodeInput)}");
                stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTNumberNodeInput? numberLiteral = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.NumberLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTNumberNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTNumberNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTNumberNodeInput)}");
                numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTBooleanNodeInput? booleanLiteral = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.BooleanLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTBooleanNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTBooleanNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTBooleanNodeInput)}");
                booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTLLMNodeInput? llm = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLLMNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLLMNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTLLMNodeInput)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTDynamicVariableNodeInput? dynamicVariable = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.DynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTDynamicVariableNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTDynamicVariableNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTDynamicVariableNodeInput)}");
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTOrOperatorNodeInput? orOperator = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.OrOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTOrOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTOrOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTOrOperatorNodeInput)}");
                orOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTAndOperatorNodeInput? andOperator = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.AndOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTAndOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTAndOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTAndOperatorNodeInput)}");
                andOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTEqualsOperatorNodeInput? eqOperator = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.EqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTEqualsOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTEqualsOperatorNodeInput)}");
                eqOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTNotEqualsOperatorNodeInput? neqOperator = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.NeqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTNotEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTNotEqualsOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTNotEqualsOperatorNodeInput)}");
                neqOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTGreaterThanOperatorNodeInput? gtOperator = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.GtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTGreaterThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTGreaterThanOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTGreaterThanOperatorNodeInput)}");
                gtOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTLessThanOperatorNodeInput? ltOperator = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.LtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLessThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLessThanOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTLessThanOperatorNodeInput)}");
                ltOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTGreaterThanOrEqualsOperatorNodeInput? gteOperator = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.GteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTGreaterThanOrEqualsOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTGreaterThanOrEqualsOperatorNodeInput)}");
                gteOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ASTLessThanOrEqualsOperatorNodeInput? lteOperator = default;
            if (discriminator?.Type == global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType.LteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLessThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLessThanOrEqualsOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ASTLessThanOrEqualsOperatorNodeInput)}");
                lteOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ChildrenItem3(
                discriminator?.Type,
                stringLiteral,

                numberLiteral,

                booleanLiteral,

                llm,

                dynamicVariable,

                orOperator,

                andOperator,

                eqOperator,

                neqOperator,

                gtOperator,

                ltOperator,

                gteOperator,

                lteOperator
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChildrenItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTStringNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTStringNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTStringNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringLiteral, typeInfo);
            }
            else if (value.IsNumberLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTNumberNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTNumberNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTNumberNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberLiteral, typeInfo);
            }
            else if (value.IsBooleanLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTBooleanNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTBooleanNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTBooleanNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BooleanLiteral, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLLMNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLLMNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTLLMNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeInfo);
            }
            else if (value.IsDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTDynamicVariableNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTDynamicVariableNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTDynamicVariableNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeInfo);
            }
            else if (value.IsOrOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTOrOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTOrOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTOrOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrOperator, typeInfo);
            }
            else if (value.IsAndOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTAndOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTAndOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTAndOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndOperator, typeInfo);
            }
            else if (value.IsEqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EqOperator, typeInfo);
            }
            else if (value.IsNeqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTNotEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTNotEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTNotEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NeqOperator, typeInfo);
            }
            else if (value.IsGtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTGreaterThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTGreaterThanOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTGreaterThanOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GtOperator, typeInfo);
            }
            else if (value.IsLtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLessThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLessThanOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTLessThanOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LtOperator, typeInfo);
            }
            else if (value.IsGteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTGreaterThanOrEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GteOperator, typeInfo);
            }
            else if (value.IsLteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ASTLessThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ASTLessThanOrEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ASTLessThanOrEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LteOperator, typeInfo);
            }
        }
    }
}