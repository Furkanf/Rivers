using System;

namespace Rivers.Analysis.Traversal
{
    /// <summary>
    /// Provides members for traversing a graph.
    /// </summary>
    public interface ITraversal
    {
        /// <summary>
        /// Fires when a node is about to be traversed by the traversal.
        /// </summary>
        event EventHandler<NodeDiscoveryEventArgs> NodeDiscovered;

        /// <summary>
        /// Fires when the traversal is completed.
        /// </summary>
        event EventHandler TraversalCompleted;
        
        /// <summary>
        /// Performs the traversal algorithm.
        /// </summary>
        /// <param name="entrypoint">The starting node.</param>
        void Run(Node entrypoint);
    }
}