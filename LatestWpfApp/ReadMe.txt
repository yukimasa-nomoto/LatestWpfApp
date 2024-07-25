2024/07/25
・ViewModel 

・Microsoft.Xaml.Behaviors.Wpf
	xmlns:i="http://schemas.microsoft.com/xaml/behaviors"
	https://elf-mission.net/programming/wpf/wpf-tips/xaml-behaviors-wpf-interactivity/
		ここが参考になるかも
	github
		https://github.com/microsoft/XamlBehaviorsWpf
			Downloadフォルダーにあるので動作を１つ１つ見る。これを作っていく
				・Animation
					・ControlStoryboardControl
						button自体が動作するanimationを設定する
					・FluidMoveBehavior
						消した四角が上に行くanimationが動く
					・MouseDragElementBehavior
						ものをmouseでdragできる
					・FluidMoveSetTagBehavior
						ちょっとむずい。指定した要素が、指定した位置へ移動する
					・TouchBehaviorControl
						タッチパネル用っぽい。
				・Condition
					・CallMethodControl	ViewModelを絡める。	
				kokokara


	以下実装したけど消してやり直す
		・Trigger
			・ボタン押下処理
				<i:Interaction.Triggers>
					<i:EventTrigger EventName="Click">
						<i:CallMethodAction TargetObject="{Binding}"
											MethodName="GetBrightness"/>
					</i:EventTrigger>
				</i:Interaction.Triggers>
			・コンボ変更処理
				<i:Interaction.Triggers>
					<i:EventTrigger EventName="Click">
						<i:CallMethodAction TargetObject="{Binding}"
												MethodName="ButtonClick"/>
					</i:EventTrigger>
				</i:Interaction.Triggers>

		・Behaviors



