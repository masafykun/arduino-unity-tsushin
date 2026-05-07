# arduino-unity-tsushin

> Arduino × Unity シリアル通信プロジェクト（指センサーバージョン）

## 概要

Arduino と Unity をシリアル通信で連携させるプロジェクトです。
指の動きを検知するセンサーから Arduino 経由で Unity にデータを送り、3D オブジェクトを制御することを想定しています。

- `SerialReadLeft.cs`：Arduino から受信したデータを Unity 側で処理
- `ButtonLeft.cs` / `ChangeColorOnHit.cs` / `oyayubi.cs`：オブジェクト制御スクリプト群
- 衝突時の色変更（`ChangeColorOnHit`）や当たり判定（`atari.physicMaterial`）を実装

## 使用技術

- Unity（C#）
- Arduino（シリアル通信）
- SerialPort（UnityEngine）

## 動作環境 / 注意事項

- Arduino スクリプトおよび接続回路は別途用意が必要です（本リポジトリには未同梱）
- Windows 環境推奨（COM ポートの設定が必要）
- そのままでは動作しません

## ライセンス

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=flat-square)](https://opensource.org/licenses/MIT)

このプロジェクトは **MIT ライセンス** のもとで公開しています。  
使用・参考にした際はできる限り作者へのクレジット表記をお願いします。

© 2025 masafykun (https://github.com/masafykun)
