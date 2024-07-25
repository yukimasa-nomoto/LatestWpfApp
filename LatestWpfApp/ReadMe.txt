2024/07/25
・ViewModel 

・Microsoft.Xaml.Behaviors.Wpf
	xmlns:i="http://schemas.microsoft.com/xaml/behaviors"
	https://elf-mission.net/programming/wpf/wpf-tips/xaml-behaviors-wpf-interactivity/
		ここが参考になるかも
	github
		https://github.com/microsoft/XamlBehaviorsWpf
			Downloadフォルダーにあるので動作を１つ１つ見る。これを作っていく





	以下実装したけどコメントアウトしておく
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



