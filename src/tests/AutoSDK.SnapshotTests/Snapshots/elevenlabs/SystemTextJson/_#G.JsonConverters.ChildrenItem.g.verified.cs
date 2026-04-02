//HintName: G.JsonConverters.ChildrenItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChildrenItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChildrenItem>
    {
        /// <inheritdoc />
        public override global::G.ChildrenItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTAndOperatorNodeInputChildrenItemDiscriminator>(ref readerCopy, options);

            global::G.ASTStringNodeInput? stringLiteral = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.StringLiteral)
            {
                stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTStringNodeInput>(ref reader, options);
            }
            global::G.ASTNumberNodeInput? numberLiteral = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NumberLiteral)
            {
                numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTNumberNodeInput>(ref reader, options);
            }
            global::G.ASTBooleanNodeInput? booleanLiteral = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.BooleanLiteral)
            {
                booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTBooleanNodeInput>(ref reader, options);
            }
            global::G.ASTLLMNodeInput? llm = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTLLMNodeInput>(ref reader, options);
            }
            global::G.ASTDynamicVariableNodeInput? dynamicVariable = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.DynamicVariable)
            {
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTDynamicVariableNodeInput>(ref reader, options);
            }
            global::G.ASTOrOperatorNodeInput? orOperator = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.OrOperator)
            {
                orOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTOrOperatorNodeInput>(ref reader, options);
            }
            global::G.ASTAndOperatorNodeInput? andOperator = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.AndOperator)
            {
                andOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTAndOperatorNodeInput>(ref reader, options);
            }
            global::G.ASTEqualsOperatorNodeInput? eqOperator = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.EqOperator)
            {
                eqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTEqualsOperatorNodeInput>(ref reader, options);
            }
            global::G.ASTNotEqualsOperatorNodeInput? neqOperator = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NeqOperator)
            {
                neqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTNotEqualsOperatorNodeInput>(ref reader, options);
            }
            global::G.ASTGreaterThanOperatorNodeInput? gtOperator = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GtOperator)
            {
                gtOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTGreaterThanOperatorNodeInput>(ref reader, options);
            }
            global::G.ASTLessThanOperatorNodeInput? ltOperator = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LtOperator)
            {
                ltOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTLessThanOperatorNodeInput>(ref reader, options);
            }
            global::G.ASTGreaterThanOrEqualsOperatorNodeInput? gteOperator = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GteOperator)
            {
                gteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTGreaterThanOrEqualsOperatorNodeInput>(ref reader, options);
            }
            global::G.ASTLessThanOrEqualsOperatorNodeInput? lteOperator = default;
            if (discriminator?.Type == global::G.ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LteOperator)
            {
                lteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ASTLessThanOrEqualsOperatorNodeInput>(ref reader, options);
            }

            var __value = new global::G.ChildrenItem(
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
            global::G.ChildrenItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStringLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringLiteral, typeof(global::G.ASTStringNodeInput), options);
            }
            else if (value.IsNumberLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberLiteral, typeof(global::G.ASTNumberNodeInput), options);
            }
            else if (value.IsBooleanLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BooleanLiteral, typeof(global::G.ASTBooleanNodeInput), options);
            }
            else if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::G.ASTLLMNodeInput), options);
            }
            else if (value.IsDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeof(global::G.ASTDynamicVariableNodeInput), options);
            }
            else if (value.IsOrOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrOperator, typeof(global::G.ASTOrOperatorNodeInput), options);
            }
            else if (value.IsAndOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndOperator, typeof(global::G.ASTAndOperatorNodeInput), options);
            }
            else if (value.IsEqOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EqOperator, typeof(global::G.ASTEqualsOperatorNodeInput), options);
            }
            else if (value.IsNeqOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NeqOperator, typeof(global::G.ASTNotEqualsOperatorNodeInput), options);
            }
            else if (value.IsGtOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GtOperator, typeof(global::G.ASTGreaterThanOperatorNodeInput), options);
            }
            else if (value.IsLtOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LtOperator, typeof(global::G.ASTLessThanOperatorNodeInput), options);
            }
            else if (value.IsGteOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GteOperator, typeof(global::G.ASTGreaterThanOrEqualsOperatorNodeInput), options);
            }
            else if (value.IsLteOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LteOperator, typeof(global::G.ASTLessThanOrEqualsOperatorNodeInput), options);
            }
        }
    }
}