using System;

using Microsoft.CodeAnalysis;

using Instances = R5T.X0010.Instances;


namespace System
{
    public static class SyntaxNodeExtensions
    {
        public static TParentNode AddNode<TParentNode, TNode>(this TParentNode parentNode,
            TNode node,
            Func<TParentNode, TNode, TParentNode> addSimple,
            out SyntaxAnnotation annotation)
            where TParentNode : SyntaxNode
            where TNode : SyntaxNode
        {
            var output = Instances.SyntaxOperator_AddSimpleWithAnnotations.AddNode(
                parentNode,
                node,
                addSimple,
                out annotation);

            return output;
        }
    }
}
