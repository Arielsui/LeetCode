// Source : https://leetcode.com/problems/same-tree/ 
// Author : codeyu 
// Date : Thursday, March 9, 2017 11:50:32 PM 

/**********************************************************************************
*
* 
* Given two binary trees, write a function to check if they are equal or not.
* 
* 
* Two binary trees are considered equal if they are structurally identical and the nodes have the same value.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class Solution100
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if(p == null && q == null) return true; //顺序很重要，先判断
            if(p == null || q == null) return false;
            if(p.Val != q.Val) return false;
            return IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right);
        }
    }
}

