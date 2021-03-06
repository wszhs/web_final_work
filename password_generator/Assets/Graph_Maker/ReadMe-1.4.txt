----------------------------------------------
            Graph Maker
 Copyright � 2013-2015 Stuart S.
    http://forum.unity3d.com/threads/202437
----------------------------------------------

Thank you for buying Graph Maker!

Please read the manual (GraphMaker.pdf) for more detailed documentation.

For questions, suggestions, bugs: email rorakin3@gmail.com or post in the Unity thread.

-----------------
 Installation
-----------------

This pack primarily supports:

-- UGUI and NGUI
UGUI (Graph_Maker_UGUI)
NGUI (Graph_Maker_NGUI)

-- Daikon Forge was also a supported GUI system, but is no longer updated for Graph Maker since the GUI system is not updated anymore. To use this, import the following package:
Graph_Maker_DF

-- If needed, there are also packages for older Versions of NGUI / Unity
NGUI 2.7 (Graph_Maker_NGUI_2.7)
NGUI + Unity 3.5 (Graph_Maker_NGUI_Unity_3.5)
NGUI 2.7 + Unity 3.5 (Graph_Maker_NGUI_2.7_Unity_3.5)

Can only install one at a time.

Note that DOTween is by default included in the package for animations. 
If DOTween is already in your project, make sure to uncheck the DOTween folder during import.


-----------------
 Version History
-----------------
1.4
- NOTE: This version brings many many changes, and is thus incompatible with previous Graph Maker versions.
- NEW: A new type of graph has been added called Ring Graph.
- NEW: Custom Editors! Now it is much easier to interact with publicly exposed Graph Maker variables via the Unity Editor.
- NEW: Pie graph updates! Now possible to make doughnut graphs from pie graphs. Also possible to explode slices such that they evenly align at the outside edge.
- NEW: X/Y axis Labeling system rewritten / greatly improved for axis graphs. Use label types to easily define label behavior. Can now also be independent from grid ticks.
- NEW: Legend system has been rewritten. Pie graphs and Axis Graphs now use identical legend code, and legend parameters are specified on a legend specific object.
- NEW: Now possible to graph null values (e.g. broken line segments). Use the newly added groups and enable grouping variables to do this.
- NEW: The animation library HOTween has been replaced with the newer / faster animation library DOTween.
- NEW: WMG_Data_Source has been added to make it easy to auto pull data from a generic object data source using reflection. Works for PlayMaker variables as well.
- CHANGE: All graphs now expose a public Refresh() function, and an Auto Refresh boolean. Disable auto refresh and manually call Refresh() for slightly improved performance.
- CHANGE: X/Y axis lengths have been removed. This is now controlled entirely by the width / height of the root rect transform / NGUI widget.
- CHANGE: Daikon Forge is no longer supported / updated since this GUI system is no longer supported / updated.

1.3.9
- NEW: Radar graphs! Now you can create pentagonal or other shape based graphs!
- NEW: Graphs can now dynamically resize! There are several options to select what gets resized. Because of this change, you may get runtime errors upgrading Graph Maker from a previous version. To solve this ensure your existing graphs have a RectTransform or a NGUI widget component at the graph root.
- FIX: Building for Windows Phone 8 reflection issues addressed with separate reflection static class with assembly directives. Note that HOTween dll also needs to be changed for WP8 build (refer to HOTween website).
- FIX: All animations are now independent of time scale (can work during pause screen).
- FIX: The auto-update space between functionality behavior has been improved.

1.3.8
- NEW: UGUI Support!

1.3.7
- NEW: Data labels! Add and customize data labels for each series.
- NEW: Titles! Optionally include x / y axis titles, and a graph title.
- NEW: Bar charts don't have to start from the bottom! Freely move around the base for bar charts to create upside down bar charts, or a combination.
- NEW: Additional legend options! Legends can now have multiple rows (horizontal legends), or columns (vertical legends). 

1.3.6.1 
- FIX: Fixed error during build for NGUI.

1.3.6
- NEW: Stacked line graphs and ability to add custom area shading for any line series added using advanced custom shaders created using Shader Forge!

1.3.5
- NEW: Hierarchical skill trees! Example scene has been added to demonstrate skill trees. Create your own skill trees by specifying nodes and links.

1.3.4
- NEW: Out of the box tooltips! Doing tooltips no longer requires you to write any code, simply set some graph level parameters!
- NEW: Automatic animations! Several animations are now possible without requiring you to write any code, simply set some graph level parameters!
- NEW: Series level setting to add more spacing between series. This is useful to have bar graphs where the bars are not right next to eachother.
- NEW: More dynamic axis type settings. New auto origin - x/y options allow the axes to position closest to the origin. The origin is also configurable.
- NEW: For the auto axes type options, you can now also specify whether the axes lock to the nearest gridline or move around freely.

1.3.3
- NEW: Click and hover events have been added to make adding interactivity to graphs very easy.
- NEW: Line padding variable added to series script to allow creating lines that don't exactly touch at the point. Useful for creating hollow points.
- NEW: Hide x / y axis tick boolean variables added to the graph, can be used to show / hide axis ticks independently of labels and vice versa.
- NEW: Hide legend labels boolan variable added, useful now that legend events can be added, since this can be shown in a tooltip.
- NEW: API for dynamically instantiating and deleting series, useful if you don't know how many series you will have for a given graph.
- NEW: NGUI 2.7 is now supported for both Unity 4 and Unity 3.5.
- CHANGE: Data generation example scene code is now mostly GUI system independent.
- CHANGE: Functionality in the manager script has been split up: caching, data generators, events, and path finding are now smaller separate scripts.

1.3.2
- NEW: Animations! Example scene has been updated to demonstrate the use of the animation functions. All animations use HOTween.
- FIX: Fixed issues for Daikon version upgrade 1.0.13 -> 1.0.14
- FIX: Different default link prefab is now used for all lines in all graphs, which improves overall line quality.
- FIX: Axis Graph script is now fully cached, performance should be the best it can possibly be. This removed the refresh every frame variable.
- NOTE: These changes break backwards compatibility, but can be easily addressed
- FIX: Prefab reference variables moved from series to graph script, so they don't need to be set for each series.
- FIX: Line Width variable renamed to Line Scale

1.3.1
- FIX: Fixed issue discovered when upgrading DFGUI version where first label not positioned correctly
- FIX: WMG_Grid now implements caching, increasing general performance for all graphs (WMG_Grid is used for grid lines and axis labels)

1.3
- NOTE: This version brings many changes that break backwards compatibility, highly recommend remaking your existing graphs from the new examples.
- NEW: New interactive example scene added for both NGUI and Daikon that showcases many Graph Maker features.
- NEW: Ability to do real-time update for an arbitrary float variable (uses reflection similar to property binding in Daikon).
- NEW: Codebase refactored to use nearly all GUI independent code. All NGUI and Daikon specific code in a manager script.
- NEW: Ability to automatically set x / y axis min / max values based on series point data added.
- NEW: Ability to specify an axes type. This sets the axes positions based on a quadrant type.
- NEW: Added an axes width variable to more easily change the width of the axes.
- NEW: Legend entry font size variable added.
- NEW: Connect first to last variable added, which links the first and last points. Useful for creating a circle.
- NEW: Added hide x / y labels variables.
- FIX: Huge performance improvement for the update every frame functionality with caching, this removed the series update boolean.
- FIX: Resolved offset issues in Daikon due to differences in pivot / position behavior in NGUI vs Daikon.
- FIX: Auto space based on number of points variables moved from graph script to series script.
- FIX: Replaced point / line prefab variables with a list of prefabs to easily switch prefabs at runtime.
- FIX: "Don't draw ... by default" and list of booleans "Hide Lines / Points" replaced with single hide points / lines boolean.
- FIX: Changed the axis lines to always be center pivoted to resolve some axis positioning issues.
- FIX: Fixed some vertical vs horizontal issues. Behavior is to swap many x / y specific values instead of rotate everything.
- FIX: Tick offset float variables replaced with above vs below and right vs left booleans. The axes type automatically sets these.

1.2.1:
- NEW: Added support for Daikon Forge
- NEW: Added support for NGUI + Unity 3.5

1.2:
- NEW: Upgraded from NGUI 2.7 to 3.0
- NEW: Graph type parameter to switch between line, side-by-side bar, stacked bar, and percentage stacked bar.
- NEW: Orientation type parameter to switch between vertical and horizontal graphs. Useful for horizontal bar charts.
- NEW: Added parameters to control placement of axes and what axis arrows display. Can now make 4-quadrant graphs.
- NEW: Scatter plot prefab added to showcase changes made to better support scatter plots.
- FIX: Series point value data changed from Float to Vector2 to more easily support scatter plots and arbitrary data plotting.
- FIX: Negative values did not update all labels properly, and data was also not positioned correctly for negative values.

1.1:
- NEW: First Unity Asset Store published version

1.0:
- NEW: Created
