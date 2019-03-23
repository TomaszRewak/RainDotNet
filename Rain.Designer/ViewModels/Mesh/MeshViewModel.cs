﻿using Rain.Designer.DataStructures;
using Rain.Designer.ViewModels.Common;
using Rain.Designer.ViewModels.Mesh.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Rain.Designer.ViewModels.Mesh
{
	internal class MeshViewModel : ViewModel
	{
		private readonly NodesHelper _nodesHelper;
		private readonly ConnectionsHelper _connectionsHelper;

		public MeshViewModel(
			NodesHelper nodesHelper,
			ConnectionsHelper connectionsHelper)
		{
			_nodesHelper = nodesHelper;
			_connectionsHelper = connectionsHelper;

			Nodes = new[] {
				new NodeViewModel() { Position = new MeshPoint(2, 2) },
				new NodeViewModel() { Position = new MeshPoint(2, 3) },
				new NodeViewModel() { Position = new MeshPoint(3, 3) }
			};
		}

		private IReadOnlyCollection<NodeViewModel> _nodes = new List<NodeViewModel>();
		public IReadOnlyCollection<NodeViewModel> Nodes
		{
			get => _nodes;
			private set => Set(ref _nodes, value).Then(UpdateConnections);
		}

		private IReadOnlyCollection<ConnectionViewModel> _connections = new List<ConnectionViewModel>();
		public IReadOnlyCollection<ConnectionViewModel> Connections
		{
			get => _connections;
			private set => Set(ref _connections, value);
		}

		private NodeViewModel _selectedNode = null;
		public NodeViewModel SelectedNode
		{
			get => _selectedNode;
			private set => Set(ref _selectedNode, value);
		}

		private void UpdateConnections()
		{
			Connections = _connectionsHelper.UpdateConnections(Nodes, Connections);
		}

		private void AddNode(MeshPoint meshPoint)
		{
			Nodes = _nodesHelper.AddNode(Nodes, meshPoint);
		}

		private void RemoveNode(MeshPoint meshPoint)
		{
			Nodes = _nodesHelper.RemoveNode(Nodes, meshPoint);
		}

		private void SelectNode(MeshPoint meshPoint)
		{
			SelectedNode = Nodes.FirstOrDefault(node => node.Position == meshPoint);
		}

		public ICommand AddNodeCommand => new Command<MeshPoint>(AddNode);
		public ICommand RemoveNodeCommand => new Command<MeshPoint>(RemoveNode);
		public ICommand SelectNodeCommand => new Command<MeshPoint>(SelectNode);
	}
}
