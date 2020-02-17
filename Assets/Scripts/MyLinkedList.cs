using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLinkedList
{
    Node Header;
    Node Current;
    Node LastNode;

    public MyLinkedList(GameObject d)
    {
        //Header == null;
        Header = new Node(d);

        Current = Header;
        LastNode = Header;
    }
    public GameObject GetCurrent()
    {
        return Current.data;
    }
    public void Add(GameObject d)
    {
        Node newNode = new Node(d);
        newNode.nextNode = Current.nextNode;
        Current.nextNode = newNode;
    }
    public void AddFirst(GameObject d)
    {
        //Node newNode = new Node(d);
        Node newNode = new Node(d);

    }
    public void AddLast(GameObject d)
    {
        //Node newNode = new Node(d);

    }

    public void RemoveNext()
    {
        if (Current.nextNode == null)
        {
            Node tempNode = Current.nextNode;
            Current.nextNode = Current.nextNode.nextNode;
            tempNode = null; //Destroy(tempNode)
        }
        
    }
    public void MoveTonext()
    {
        if (Current.nextNode != null)
        {
            Current = Current.nextNode;
        }
    }
}

public class Node
{
    public GameObject data;
    public Node nextNode;

    public Node (GameObject d)
    {
        data = d;
        nextNode = null;
    }

}
