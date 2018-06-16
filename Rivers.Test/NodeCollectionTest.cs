﻿using System;
using Xunit;

namespace Rivers.Test
{
    public class NodeCollectionTest
    {
        [Fact]
        public void EmptyCollection()
        {
            var g = new Graph();
            Assert.Equal(0, g.Nodes.Count);
        }

        [Fact]
        public void AddNode()
        {
            var g = new Graph();
            var node = new Node("1");
            
            g.Nodes.Add(node);

            Assert.Equal(1, g.Nodes.Count);
            Assert.Contains(node, g.Nodes);
            Assert.Equal(g, node.ParentGraph);
        }


        [Fact]
        public void AddNodeTwice()
        {
            var g = new Graph();
            var node = new Node("1");
            
            g.Nodes.Add(node);
            g.Nodes.Add(node);

            Assert.Equal(1, g.Nodes.Count);
        }

        [Fact]
        public void RemoveNode()
        {
            var g = new Graph();
            var node = new Node("1");
            
            g.Nodes.Add(node);
            g.Nodes.Remove(node);

            Assert.DoesNotContain(node, g.Nodes);
        }

        [Fact]
        public void AddNodeFromDifferentGraph()
        {
            var g1 = new Graph();
            var g2 = new Graph();
            var node = new Node("1");
            
            g1.Nodes.Add(node);

            Assert.Throws<ArgumentException>(() => g2.Nodes.Add(node));
        }
    }
}