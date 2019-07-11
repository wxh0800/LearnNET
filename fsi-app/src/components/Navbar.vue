<template>
	<b-navbar toggleable="md" type="dark" variant="primary" class="mb-3">
		<b-navbar-brand :to="{name: 'Home'}">App Name</b-navbar-brand>
		<b-navbar-toggle target="nav_collapse"></b-navbar-toggle>
		<b-collapse is-nav id="nav_collapse">
			<b-navbar-nav>
				<li class="nav-item">
					<router-link class="nav-link" :to="{name: 'Home'}">Home</router-link>
				</li>
				<li class="nav-item">
					<router-link class="nav-link" :to="{name: 'Search'}">Search</router-link>
				</li>
				<li class="nav-item">
					<router-link class="nav-link" :to="{name: 'Assignments'}">Assignments</router-link>
				</li>
			</b-navbar-nav>
			<b-navbar-nav class="ml-auto">
				<li class="nav-item">
					<router-link class="nav-link" :to="{name: 'Login'}">Login</router-link>
				</li>
			</b-navbar-nav>
		</b-collapse>
	</b-navbar>
</template>

<script>
export default {
	name: 'navbar'
}
</script>
