using Godot;
using System;

public partial class SplashText : Label {
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}
	
	private void OnResize() {
		int[] size = new int[] {
			(int) GetViewport().GetVisibleRect().Size.X,
			(int) GetViewport().GetVisibleRect().Size.Y
		};
		GD.Print(size[0] + ", " + size[1]);
	}
}
