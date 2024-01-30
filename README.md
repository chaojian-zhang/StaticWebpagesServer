# StaticWebpagesServer

Pass as first argument the content root (folder to serve).

## A Comment on Godot 4 Web Publish

See issue: https://github.com/godotengine/godot-proposals/issues/6616
Indeed it looks like it's not an issue on the Godot size.

For anyone who just wish to test the web build locally, use the build in [Release page](https://github.com/chaojian-zhang/StaticWebpagesServer/releases) for Godot (requires .Net 8 ASP.Net core runtime)

The key elements for server configuration are shown in those two commits:
1. https://github.com/chaojian-zhang/StaticWebpagesServer/commit/db7e1a32f72874c21d5f6a490a40d37a3ecf1c84
2. https://github.com/chaojian-zhang/StaticWebpagesServer/commit/623879f7167bbbcbd8f6d3f89f26f920a25c92aa

Reddit discussion: https://www.reddit.com/r/godot/comments/13nfnaw/cant_run_the_web_export_of_my_game_on_godot_4/
