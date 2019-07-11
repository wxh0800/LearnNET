<template>
		<nav class="col-md-2 d-none d-md-block bg-dark pr-0 pl-0 mt-n3 sidebar">
			<div class="sidebar-sticky">
				<ul class="nav flex-column">
					<li class="nav-item">
						<router-link class="nav-link" class-active='' :to="{name: 'AssignmentList'}">
							<fa icon='home'/> Assignment List
						</router-link>
					</li>
					<li class="nav-item">
						<router-link class="nav-link" :to="{name: 'AssignmentInspectorReports'}">
							<fa icon='pencil-alt'/> Inspector Reports
						</router-link>
					</li>
					<li class="nav-item">
						<router-link class="nav-link" :to="{name: 'AssignmentMetrics'}">
							<fa icon='chart-pie'/> Metrics
						</router-link>
					</li>
				</ul>
			</div>
		</nav>
</template>

<style lang='scss' scoped>
@import '@/assets/bootstrap.scss';

.sidebar {
	.nav-link {
		color: #fff;

		&:hover, &.router-link-active {
			background-color: #fff;
			font-weight: bold;
			@extend .text-primary;
		}
	}
}

.sidebar-sticky {
	position: relative;
	top: 0;
	height: calc(100vh - 56px);
	overflow-x: hidden;
	overflow-y: auto;
}

@supports ((position: -webkit-sticky) or (position: sticky)) {
	.sidebar-sticky {
		position: -webkit-sticky;
		position: sticky;
	}
}
</style>
