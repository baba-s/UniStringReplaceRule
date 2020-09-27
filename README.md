# UniStringReplaceRule

文字列の置換ルールを管理する構造体

# 使用例

## 通常

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
	private void Awake()
	{
		var name   = "ピカチュウ";
		var result = name.Replace( "ピカチュウ", "カイリュー" );

		Debug.Log( result ); // カイリュー
	}
}
```

## UniStringReplaceRule

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
	private void Awake()
	{
		var name   = "ピカチュウ";
		var rule   = new StringReplaceRule( "ピカチュウ", "カイリュー" );
		var result = name.Replace( rule );

		Debug.Log( result ); // カイリュー
	}
}
```
