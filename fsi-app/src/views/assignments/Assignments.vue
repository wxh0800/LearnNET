<template>
    <div class='container-fluid'>
		<div class="row">
			<sidebar />
			<main class="col-md-10 ml-sm-auto">
				<h4 class="title">Assignments</h4>
				<hr>
				<router-view />
			</main>
		</div>
	</div>
</template>

<script>
import Sidebar from '@/components/assignments/Sidebar'

export default {
	components: {
		'sidebar': Sidebar
	}
}
</script>
