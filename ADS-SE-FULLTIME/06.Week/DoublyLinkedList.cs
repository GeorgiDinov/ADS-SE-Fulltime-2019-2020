﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Week_6
{
    public class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }

        public DoublyLinkedListNode<T> Next { get; set; }

        public DoublyLinkedListNode<T> Previous { get; set; }
    }

    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> head;
        private DoublyLinkedListNode<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var node = new DoublyLinkedListNode<T> { Value = item };

            if (this.Count == 0)
            {
                this.tail = this.head = node;
            }
            else if (this.Count == 1)
            {
                this.head = node;
                this.head.Next = this.tail;
                this.tail.Previous = this.head;
            }
            else
            {
                node.Next = this.head;
                this.head.Previous = node;
                this.head = node;
            }

            this.Count++;
        }

        public void AddLast(T item)
        {
            var node = new DoublyLinkedListNode<T> { Value = item };

            if (this.Count == 0)
            {
                this.head = this.tail = node;
            }
            else if (this.Count == 1)
            {
                this.tail = node;
                this.tail.Previous = this.head;
                this.head.Next = node;
            }
            else
            {
                node.Previous = this.tail;
                this.tail.Next = node;
                this.tail = node;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedItem = this.head.Value;

            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.head = this.head.Next;
                this.head.Previous = null;
            }

            this.Count--;

            return removedItem;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedItem = this.tail.Value;

            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.tail = this.tail.Previous;
                this.tail.Next = null;
            }

            this.Count--;

            return removedItem;
        }
    }
}
