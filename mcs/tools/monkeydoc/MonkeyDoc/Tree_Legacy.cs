using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml;
using System.Collections.Generic;

namespace MonkeyDoc
{
	public partial class Tree
	{
		public List<Node> Nodes {
			get {
				return RootNode.Nodes;
			}
		}
	}
}